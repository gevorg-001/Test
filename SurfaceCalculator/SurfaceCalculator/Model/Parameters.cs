namespace SurfaceCalculator.Model
{
    public class Parameters
    {
        
    private List<double> _list;

        public List<double> Parameter
        {
            get { return _list; }
            set
            {
                if ( value.All(x => x > 0))
                {
                    _list = value;
                }
                else
                {
                    throw new ArgumentException("Parameter must be a non-null List<int> with all positive values.");
                }
            }
        }
    }
}
