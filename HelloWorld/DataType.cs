
class DataType
{
    static void Main(string[] args){

        int x = 5, y = 10, z = 9;
        Console.WriteLine($"{x}, {y}, {z}");
        Console.WriteLine("---------Data Type: Int ---------");
        int age  = -23;
        Console.WriteLine(age);
        Console.WriteLine("Max Value: "+int.MaxValue);//2147483647
        Console.WriteLine("Min Value: "+ int.MinValue);//-2147483648
        Console.WriteLine("---------Data Type: Long --------");
        long bigNumber = -90000002323L;
        Console.WriteLine(bigNumber);
        Console.WriteLine("Max Value: "+long.MaxValue);//9223372036854775807
        Console.WriteLine("Min Value: "+long.MinValue);//-9223372036854775808
        Console.WriteLine("---------Data Type: Double ------");
        double doubleV = 14.56; //we do not add any suffix by default decimal place value would be consider as type of double
        Console.WriteLine(doubleV);
        Console.WriteLine("Max Value: "+double.MaxValue);//9223372036854775807
        Console.WriteLine("Min Value: "+double.MinValue);//-9223372036854775808
        Console.WriteLine("---------Data Type: Float -------");
        float floatV = 14.56F;
        Console.WriteLine(floatV);
        Console.WriteLine("Max Value: "+float.MaxValue);//9223372036854775807
        Console.WriteLine("Min Value: "+float.MinValue);//-9223372036854775808
        Console.WriteLine("---------Data Type: Decimal ------");
        decimal decimalV = 14M;
        Console.WriteLine(decimalV);
        Console.WriteLine("Max Value: "+decimal.MaxValue);//9223372036854775807
        Console.WriteLine("Min Value: "+decimal.MinValue);//-9223372036854775808

        age = 56;
        
        Console.WriteLine(Environment.NewLine + age);//re-assignment

        Console.WriteLine("---------Data Type: String/char ------");
        string name ="Kirti Singh";
        char letter = 'U';
        Console.WriteLine("String: "+ name);
        Console.WriteLine("char: "+letter);

        string StrAge = "23";
        Console.WriteLine(Environment.NewLine + "String to Int: " +Convert.ToInt32(StrAge));



    }
}

