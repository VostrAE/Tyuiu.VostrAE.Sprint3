using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VostrAE.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            replaceable = 'a';
            replacement = '*';
            foreach (char repleceable in value)
            {
                if (replaceable == 'a')
                {
                    value = value.Replace(replaceable, replacement);
                }
            }
            return value;
        }
    }
}
