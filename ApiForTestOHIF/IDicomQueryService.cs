﻿using FellowOakDicom;

namespace ApiForTestOHIF
{
    public interface IDicomQueryService
    {
        IEnumerable<DicomDataset> Find
        (
            DicomDataset request,
            IQueryOptions options,
            string queryLevel
        );

        PagedResult<DicomDataset> FindPaged
        (
            DicomDataset request,
            IQueryOptions options,
            string queryLevel
        );
    }
}
