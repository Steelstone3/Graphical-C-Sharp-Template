namespace BubblesDivePlanner.GasManagement
{
    public class GasMixtureController : IGasMixtureController
    {
        public int CalculateNitrogenMixture(int oxygen, int helium)
        {
            return 100 - oxygen - helium;
        }
    }
}