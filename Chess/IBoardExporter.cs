namespace Chess
{
    public interface IBoardExporter
    {
        void ExportBoard(IBoard board, object destination);
    }
}