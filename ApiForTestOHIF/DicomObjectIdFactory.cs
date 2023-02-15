﻿using FellowOakDicom;

namespace ApiForTestOHIF
{
    public class DicomObjectIdFactory
    {
        private static DicomObjectIdFactory _instance = new DicomObjectIdFactory();

        public static void RegisterInstance(DicomObjectIdFactory instance)
        {
            _instance = instance;
        }

        public static DicomObjectIdFactory Instance
        {
            get
            {
                return _instance;
            }
        }

        public virtual IObjectId CreateObjectId(DicomDataset dataset)
        {
            return new ObjectId()
            {
                StudyInstanceUID = dataset.GetValueOrDefault(DicomTag.StudyInstanceUID, 0, ""),
                SeriesInstanceUID = dataset.GetValueOrDefault(DicomTag.SeriesInstanceUID, 0, ""),
                SOPInstanceUID = dataset.GetValueOrDefault(DicomTag.SOPInstanceUID, 0, "")
            };
        }
    }
}
