﻿namespace ApiForTestOHIF.Models
{
    public class DefaultMediaTransferSyntax : Dictionary<string, string>
    {
        private static DefaultMediaTransferSyntax _instance = new DefaultMediaTransferSyntax();

        //TODO: review http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_6.2
        // 6.1.1.8 DICOM Media Types and Media Types For Bulk Data

        private DefaultMediaTransferSyntax()
        {
            Add(MimeMediaTypes.DICOM, "1.2.840.10008.1.2.1");
            Add(MimeMediaTypes.UncompressedData, "1.2.840.10008.1.2.1");
            //Add ( MimeMediaTypes.Jpeg, "" ) ;
            //Add ( MimeMediaTypes.Jpeg, "1.2.840.10008.1.2.4.70" ) ;
            //Add( MimeMediaTypes.Rle, "1.2.840.10008.1.2.5" ) ;
            //Add ( MimeMediaTypes.Jls, "1.2.840.10008.1.2.4.80" ) ;
            //Add ( MimeMediaTypes.Jp2, "1.2.840.10008.1.2.4.90" ) ;
            //Add ( MimeMediaTypes.Jpx, "1.2.840.10008.1.2.4.92") ;
            //Add ( MimeMediaTypes.Mpeg2, "1.2.840.10008.1.2.4.101") ;
            //Add ( MimeMediaTypes.Mp4, "1.2.840.10008.1.2.4.102" ) ;
            //Add ( MimeMediaTypes.Json, "" ) ;
            //Add ( MimeMediaTypes.xmlDicom, "" ) ;
        }

        public static DefaultMediaTransferSyntax Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
