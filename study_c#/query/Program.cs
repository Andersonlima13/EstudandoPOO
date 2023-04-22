class Query
{
    static void Principal()
    {
        int[] numbers = {1,2,5,4,9,45,55,4};

        var query = from number in numbers
                    where number < 10
                    select number; 
    }
}