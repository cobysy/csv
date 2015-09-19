namespace Csv
{
    /// <summary>
    /// Defines the options that can be passed to customize the reading or writing of csv files.
    /// </summary>
    public sealed class CsvOptions
    {
        /// <summary>
        /// Gets or sets the number of rows to skip before reading the header row, defaults to <c>0</c>.
        /// </summary>
        public int RowsToSkip { get; set; }

        /// <summary>
        ///  Gets or sets the character to use for separating data, default to <c>'\0'</c> which will auto-detect from the header row.
        /// </summary>
        public char Separator { get; set; }
    }
}