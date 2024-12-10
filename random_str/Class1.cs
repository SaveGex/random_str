namespace random_str
{

    public class Row
    {
        string _row = "NoValue";
        string _result = "NoValue";

        public Row(string row = "NoValue")
        {
            this._row = row;
        }

        public void RandBubble()
        {
            Random rand = new Random();
            char[] buffer = _row.ToCharArray();

            for (int i = 0; i < buffer.GetUpperBound(0) - 1; i++)
            {
                int clear_random_digit = rand.Next(buffer.GetUpperBound(0));

                while (clear_random_digit == i)
                {
                    int next_value = rand.Next(buffer.GetUpperBound(0));
                    clear_random_digit = next_value;
                }

                if (clear_random_digit != i)
                {
                    (buffer[clear_random_digit], buffer[i]) = (buffer[i], buffer[clear_random_digit]);
                }

            }
            _result = new string(buffer);
        }

        public string GetResult() => _result;

    }
}