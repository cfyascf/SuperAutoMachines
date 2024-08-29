using superautomachines.machines;

public static class TeamGenerator
{
    public static List<Machine> Generate(int teamsize)
    {
        Random seed = new Random();

        List<Machine> comp = new();
        for(int i = 0; i < teamsize; i++)
        {
            var tier = seed.Next(1, 7);

            switch(tier)
            {
                case 1:
                    comp.Add(TierOneGenerator.PickMachine());
                    break;

                case 2:
                    comp.Add(TierTwoGenerator.PickMachine());
                    break;

                case 3:
                    comp.Add(TierThreeGenerator.PickMachine());
                    break;

                case 4:
                    comp.Add(TierFourGenerator.PickMachine());
                    break;

                case 5:
                    comp.Add(TierFiveGenerator.PickMachine());
                    break;

                case 6:
                    comp.Add(TierSixGenerator.PickMachine());
                    break;
            }
        }

        return comp;
    }  
}