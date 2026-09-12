public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // The function should create and return an array of multiples of a number
        double[] multiples = new double[length]; // Instaniates an array of doubles of the requiredlength
        for (int i = 0; i < length; i++) // Loops through every index in the array and calculates the multiple
        {
            multiples[i] = number * (i + 1); // Calculation. Multiplies starting number by the position and adds 1 to the position
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int length = data.Count; // Gets list length to use in calculations
    
        // Extracts the last amount items from the list from idex position (length - amount)
        var lastElements = data.GetRange(length - amount, amount);
        // Removes the last amount items from the list
        data.RemoveRange(length - amount, amount);
        // Insert the extracted elements at the beginning
        data.InsertRange(0, lastElements);
    }
}
