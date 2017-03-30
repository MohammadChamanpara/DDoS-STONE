using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Library.Windows.WindowsForms.Helpers;

namespace Stone.StoneClasses
{
    public static class StoneHandler
    {
        #region Constructor
        static StoneHandler()
        {
        }
        #endregion

        #region Properties
        public static StoneDataSet DataSet { get; set; }
        #endregion

        #region Methods
        public static int GenerateDataSet(string filePath)
        {
            DataSet = new StoneDataSet();
            int tuplesCount = DataSet.GenerateRandom();
            DataSet.SaveToFile(filePath);
            return tuplesCount;
        }
        public static void Run()
        {
            AxesBuilder.Origin.Frequency = ApplicationSettings.Instance.OriginFrequency;
            AxesBuilder.Origin.LifeTime = ApplicationSettings.Instance.OriginLifeTime;
            AxesBuilder.Origin.Weight = ApplicationSettings.Instance.OriginWeight;

            AxesBuilder.Clustres = new List<StoneCluster>();

            DCC.Groups = new StoneGroup[8];
            for (int i = 0; i < 8; i++)
                DCC.Groups[i] = new StoneGroup(i);

            DataAggregator.Initialize();

            DataSet = new StoneDataSet();
            DataSet.LoadFromFile(ApplicationSettings.Instance.LoadFilePath);
            ReadFromDataSet();

            ApplicationSettings.Instance.OriginFrequency = AxesBuilder.Origin.Frequency;
            ApplicationSettings.Instance.OriginLifeTime = AxesBuilder.Origin.LifeTime;
            ApplicationSettings.Instance.OriginWeight = AxesBuilder.Origin.Weight;

            ApplicationSettings.Instance.Save();
        }
        public static void ReadFromDataSet()
        {
            if (DataSet == null || DataSet.Tuples.Count == 0)
                throw new HelperClasses.LibraryException("DataSet از فایل خوانده نشده است.");

            foreach (DataSetTuple dataSetTuple in DataSet.Tuples)
            {
                DataAggregator.AddTuple(dataSetTuple);
                FilterComponent.AddTuple(dataSetTuple);
            }
        }
        public static int LoadDataSet(string filePath)
        {
            DataSet = new StoneDataSet();
            return DataSet.LoadFromFile(filePath);
        }
        public static void Persist()
        {
            var db = DB.NewContext();

            DCC.Persist(db);

            AxesBuilder.Persist(db);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                foreach (var h in db.ClusterHistories)
                {
                    if (double.IsNaN(h.F))
                    {
                        System.Windows.Forms.MessageBox.Show("F");
                    }
                    else if (double.IsNaN(h.W))
                    {
                        System.Windows.Forms.MessageBox.Show("W");
                    }
                    else if (double.IsNaN(h.T))
                    {
                        System.Windows.Forms.MessageBox.Show("T");
                    }
                    else if (double.IsInfinity(h.F))
                    {
                        System.Windows.Forms.MessageBox.Show("F");
                    }
                    else if (double.IsInfinity(h.W))
                    {
                        System.Windows.Forms.MessageBox.Show("W");
                    }
                    else if (double.IsInfinity(h.T))
                    {
                        System.Windows.Forms.MessageBox.Show("T");
                    }
                }
                foreach (var h in db.GroupRateHistories)
                {
                    if (double.IsNaN(h.Rate))
                    {
                        System.Windows.Forms.MessageBox.Show("F");
                    }
                    else if (double.IsInfinity(h.Rate))
                    {
                        System.Windows.Forms.MessageBox.Show("W");
                    }
                }
                throw;
            }
        }
        public static void Refresh()
        {
            var db = DB.NewContext();
            ProfileMaintainer.ComputeDayWeights();
            DCC.Refresh(db);
            AxesBuilder.UpdateOrigin(db);
            ProfileMaintainer.Refresh(db);
        }
        #endregion
    }
}
