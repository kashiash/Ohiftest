﻿using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Services
{
    public interface IObjectRetrieveService
    {
        IStorageLocation RetrieveSopInstance(IObjectId query, DicomMediaProperties mediaInfo);

        IEnumerable<IStorageLocation> RetrieveSopInstances(IObjectId query, DicomMediaProperties mediaInfo);

        IEnumerable<ObjectRetrieveResult> FindSopInstances
        (
            IObjectId query,
            string mediaType,
            IEnumerable<string> transferSyntaxes,
            string defaultTransfer
        );

        IEnumerable<ObjectRetrieveResult> GetTransformedSopInstances
        (
            IObjectId query,
            string fromMediaType,
            string fromTransferSyntax,
            string toMediaType,
            string toTransferSyntax
        );

        bool ObjetInstanceExist(IObjectId objectId, string mediaType, string transferSyntax);
    }
}
