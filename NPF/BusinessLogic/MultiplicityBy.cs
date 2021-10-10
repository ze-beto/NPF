namespace NPF.BusinessLogic
{
    /// <summary>
    /// multiplicity rules
    /// </summary>
    public class Multiplicity
    {
        /// <summary>
        /// multiplicity rule check, by 11
        /// </summary>
        /// <param name="number">long number to check</param>
        /// <returns>boolean</returns>
        public static bool By11(long number)
        {
            return (number % 11 == 0);
        }
    }
}
