namespace Chess.Internal.BoardExporter.Exporters
{
    using Newtonsoft.Json;

    internal class JsonBoardExporter : IExporter
    {
        public bool CanHandleExport(object destination)
        {
            return destination is string destinationString && destinationString.EndsWith(".json");
        }

        public bool ExportBoard(IBoard board, object destination)
        {
            if (board == null)
            {
                return false;
            }

            if (destination is not string destinationString)
            {
                return false;
            }

            try
            {
                if (File.Exists(destinationString))
                {
                    File.Delete(destinationString);
                }

                var json = JsonConvert.SerializeObject(board);

                File.WriteAllText(destinationString, json);
            }
            catch // Swallow.
            {
                return false;
            }

            return true;
        }
    }
}