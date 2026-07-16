static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed <= 0)
            return 0.0;
        else if (speed <= 4)
            return 1.0;
        else if (speed <= 8)
            return 0.9;
        else if (speed == 9)
            return 0.8;
        else
            return 0.77;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int carsPerHour = 221;
        return (speed * carsPerHour) * SuccessRate(speed);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingCarsMinute = ProductionRatePerHour(speed) / 60;
        return (int)workingCarsMinute;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
