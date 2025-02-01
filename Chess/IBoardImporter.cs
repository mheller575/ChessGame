namespace Chess
{
    public interface IBoardImporter
    {
        public IBoard ImportBoard(object source);
    }
}