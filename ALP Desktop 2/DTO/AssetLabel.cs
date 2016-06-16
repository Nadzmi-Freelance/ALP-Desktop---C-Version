namespace ALP_Desktop_2.DTO
{
    class AssetLabel
    {
        /* 
         * Initialize size of the asset's elements in pixel (according to mm measurement)
         * 76px = 20mm
         * 253px = 67mm
         * 94px = 25mm
         */
        public const int QR_WIDTH = 76; // width of qr image
        public const int QR_HEIGHT = 76; // height of qr image
        public const int LABEL_WIDTH = 280; // width of full asset label
        public const int LABEL_HEIGHT = 94; // height of full asset label
        public const int COPY_PER_COLUMN_A4 = 11; // no of copy of asset label per column for A4 paper
    }
}
