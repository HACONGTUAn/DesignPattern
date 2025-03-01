namespace undo
{
    public interface ICommand
    {
        void Execute();
        void Undo();   
    }
    
}
