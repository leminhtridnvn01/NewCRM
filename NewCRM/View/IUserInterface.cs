namespace NewCRM.View
{
    public interface IUserInterface<T>
    {
        //Show main menu
        public void Show(T entity);

        //Process input selection
        public string InputSelection(string output);

        //Process selection
        public int ProcessSelection(string input);
    }
}
