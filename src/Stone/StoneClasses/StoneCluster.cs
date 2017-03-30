using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stone.StoneClasses
{
    public class StoneCluster
    {
        #region Properties
        public string Prefix { get; private set; }
        public List<DataSetTuple> DataSetTuples { get; set; }

        private double _frequency = 0;
        public double Frequency
        {
            get
            {
                if (_frequency == 0)
                {
                    if (this.DataSetTuples.Count == 0)
                        _frequency = 0;
                    else
                        _frequency = this.DataSetTuples.Average(x => x.StoneFeatures.Frequency);
                }
                return _frequency;
            }
        }

        private double _weight = 0;
        public double Weight
        {
            get
            {
                if (_weight == 0)
                {
                    if (this.DataSetTuples.Count == 0)
                        _weight = 0;
                    else
                        _weight = this.DataSetTuples.Average(x => x.StoneFeatures.Weight);
                }
                return _weight;
            }
        }

        private double _lifeTime = 0;
        public double LifeTime
        {
            get
            {
                if (_lifeTime == 0)
                {
                    if (this.DataSetTuples.Count == 0)
                        _lifeTime = 0;
                    else
                        _lifeTime = this.DataSetTuples.Average(x => x.StoneFeatures.LifeTime);
                }
                return _lifeTime;
            }
        }

        public double StartTime
        {
            get
            {
                if (this.DataSetTuples.Count == 0)
                    return 0;
                return this.DataSetTuples.First().StartTime;
            }
        }

        public double Rate
        {
            get
            {
                if (this.LifeTime == 0)
                    return 1;
                return this.Weight / this.LifeTime;
            }
        }
        #endregion

        #region Constructor
        public StoneCluster(string prefix, double weight = 0, double lifeTime = 0, double frequency = 0)
        {
            this.Prefix = prefix;
            _weight = weight;
            _frequency = frequency;
            _lifeTime = lifeTime;

            this.DataSetTuples = new List<DataSetTuple>();
        }
        #endregion

        #region Methods
        public void AddTuple(DataSetTuple dataSetTuple)
        {
            _lifeTime = 0;
            _weight = 0;
            _frequency = 0;

            DataAggregatorTuple tuple = new DataAggregatorTuple();

            tuple.OldFeatures.Frequency = this.Frequency;
            tuple.OldFeatures.Weight = this.Weight;
            tuple.OldFeatures.LifeTime = this.LifeTime;

            this.DataSetTuples.Add(dataSetTuple);

            tuple.NewFeatures.Frequency = this.Frequency;
            tuple.NewFeatures.Weight = this.Weight;
            tuple.NewFeatures.LifeTime = this.LifeTime;

            tuple.SourceCluster = this;
            tuple.StartTime = this.StartTime;
            DCC.Receive(tuple);
        }
        public void Purge(double newT0)
        {
            _lifeTime = 0;
            _weight = 0;
            _frequency = 0;

            DataAggregatorTuple tuple = new DataAggregatorTuple();

            tuple.OldFeatures.Frequency = this.Frequency;
            tuple.OldFeatures.Weight = this.Weight;
            tuple.OldFeatures.LifeTime = this.LifeTime;

            this.DataSetTuples.RemoveAll(x => x.StartTime < newT0);

            tuple.NewFeatures.Frequency = this.Frequency;
            tuple.NewFeatures.Weight = this.Weight;
            tuple.NewFeatures.LifeTime = this.LifeTime;

            tuple.SourceCluster = this;
            tuple.StartTime = this.StartTime;

            DCC.Receive(tuple);
        }
        public double ProbabilityInGroup(StoneGroup group)
        {
            double sum = 0;
            foreach (var day in ProfileMaintainer.Days)
                if (this.IsGroupMember(group, day))
                    sum += day.Weight;
            return sum;
        }
        public bool IsGroupMember(StoneGroup group, StoneDay day)
        {
            return
            (
                DB
                .NewContext()
                .GroupClusterHistories
                .Count(x => x.Day == day.Number && x.GroupNumber == group.Number && x.ClusterPrefix == this.Prefix) > 0
            );
        }
        #endregion
    }
}
