namespace Chess.Internal.BoardExporter
{
    internal interface IExporter
    {
        bool CanHandleExport(object destination);

        bool ExportBoard(IBoard board, object destination);
    }
}