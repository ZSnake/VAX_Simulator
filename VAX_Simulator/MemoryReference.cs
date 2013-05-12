namespace VAX_Simulator
{
    public class MemoryReference
    {
        readonly string _adress;
        readonly string _action;

        public MemoryReference(string adress, string action)
        {
            _adress = adress;
            _action = action;
        }
    }
}