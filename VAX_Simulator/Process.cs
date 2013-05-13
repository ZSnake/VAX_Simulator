namespace VAX_Simulator
{
    public class Process
    {
        public string _adress;
        public string _action;
        public int use;
        public Process(string adress, string action)
        {
            _adress = adress;
            _action = action;
            use = 0;
        }
    }
}