// handling ToString() Formats
Duration D1 = new Duration(1, 10, 15);
Console.WriteLine($"new Duration(1,10,15) = {D1.ToString()}");
Duration D2 = new Duration(3600);
Console.WriteLine($"new Duration (3600) = {D2.ToString()}");
Duration D3 = new Duration(7800);
Console.WriteLine($"new Duration(7800) = {D3.ToString()}");
Duration D4 = new Duration(666);
Console.WriteLine($"new Duration(666) = {D4.ToString()}");
// Try operator overloading
Console.WriteLine($"D2 += D1 => {D2+=D1}");
Console.WriteLine($"D3 = D1 + D2 => {D3 = D1 + D2}");
Console.WriteLine($"D4 = D1 + 7800 => {D4 = D1 + 7800}");
Console.WriteLine($"D3 = 666 + D3 => {D3 = 666 + D3}");
Console.WriteLine($"D3 = D1++ => {D3 = D1++}");
Console.WriteLine($"D3 = --D2 => {D3 = --D2}");
Console.WriteLine($"D1 = -D2 => {D1 = -D2}");
Console.WriteLine($"D1 = {D1.ToString()}");
Console.WriteLine($"D2 = {D2.ToString()}");
Console.WriteLine($"D3 = {D3.ToString()}");
Console.WriteLine($"If ( D1 > D2) {D1 > D2}");
Console.WriteLine($"If ( D1 < D2) {D1 < D2}");
Console.WriteLine($"If ( D1 <= D2) {D1 <= D2}");
Console.WriteLine($"If ( D1 <= D1) {D1 <= D1}");
Console.WriteLine($"If ( D1 >= D2) {D1 >= D2}");
Console.WriteLine($"If ( D2 >= D2) {D2 >= D2}");
Console.WriteLine($"If ( D1) {D1}");
Duration D5 = new Duration();
if (D5)
{
Console.WriteLine($"D5 = {D5.ToString()}");

}
else
{
    Console.WriteLine("false");
}
Console.WriteLine($"D1 = {D2.ToString()}");
DateTime obj = (DateTime)D2;
Console.WriteLine($"datetime object = {obj.ToString()}");


class Duration
{
    public int hours { get; set; }
    public int minutes { get; set; }
    public int seconds { get; set; }

    public Duration()
    {
        hours = minutes = seconds = 0;
    }

    public Duration(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public Duration(int seconds)
    {
        this.hours = seconds / 3600;
        this.minutes = (seconds / 60) % 60;
        this.seconds = seconds % 60;
    }

    public override string ToString()
    {
        if (hours == 0)
            return $"Minutes : {minutes} , Seconds : {seconds}";
        else
            return $"Hours: {hours}, Minutes : {minutes} , Seconds : {seconds}";
    }

    public override bool Equals(object? obj)
    {
        Duration duration = (Duration)obj;
        return (hours == duration.hours && minutes == duration.minutes && seconds == duration.seconds);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public static Duration operator +(Duration duration1, Duration duration2)
    {
        return new Duration()
        {
            hours = duration1.hours + duration2.hours,
            minutes = duration1.minutes + duration2.minutes,
            seconds = duration1.seconds + duration2.seconds
        };
    }
    public static Duration operator +(Duration duration1, int value)
    {
        Duration duration2 = new Duration(value);
        return new Duration()
        {
            hours = duration1.hours + duration2.hours,
            minutes = duration1.minutes + duration2.minutes,
            seconds = duration1.seconds + duration2.seconds
        };
    }
    public static Duration operator +(int value, Duration duration)
    {
        Duration duration2 = new Duration(value);
        return new Duration()
        {
            hours = duration2.hours + duration.hours,
            minutes = duration2.minutes + duration.minutes,
            seconds = duration2.seconds + duration.seconds
        };
    }
    public static Duration operator ++(Duration duration)
    {
        return new Duration(duration.hours, duration.minutes + 1, duration.seconds);
    }
    public static Duration operator --(Duration duration)
    {
        return new Duration(duration.hours, duration.minutes - 1, duration.seconds);
    }
    public static Duration operator -(Duration duration)
    {
        return new Duration(-duration.hours, -duration.minutes, -duration.seconds);
    }
    public static bool operator >(Duration duration1, Duration duration2)
    {
        if (duration1.hours > duration2.hours)
        {
            return true;
        }
        else if (duration1.hours == duration2.hours)
        {
            if (duration1.minutes > duration2.minutes)
            {
                return true;
            }
            else if (duration1.minutes == duration2.minutes)
            {
                if (duration1.seconds > duration2.seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public static bool operator <(Duration duration1, Duration duration2)
    {
        if (duration1.hours < duration2.hours)
        {
            return true;
        }
        else if (duration1.hours == duration2.hours)
        {
            if (duration1.minutes < duration2.minutes)
            {
                return true;
            }
            else if (duration1.minutes == duration2.minutes)
            {
                if (duration1.seconds < duration2.seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public static bool operator >=(Duration duration1, Duration duration2)
    {
        if (duration1.hours > duration2.hours)
        {
            return true;
        }
        else if (duration1.hours == duration2.hours)
        {
            if (duration1.minutes > duration2.minutes)
            {
                return true;
            }
            else if (duration1.minutes == duration2.minutes)
            {
                if (duration1.seconds > duration2.seconds)
                {
                    return true;
                }
                else if (duration1.seconds == duration2.seconds)
                {
                    return true ;
                }
                else
                {
                        return false ;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public static bool operator <=(Duration duration1, Duration duration2)
    {
        if (duration1.hours < duration2.hours)
        {
            return true;
        }
        else if (duration1.hours == duration2.hours)
        {
            if (duration1.minutes < duration2.minutes)
            {
                return true;
            }
            else if (duration1.minutes == duration2.minutes)
            {
                if (duration1.seconds < duration2.seconds)
                {
                    return true;
                }
                else if (duration1.seconds == duration2.seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public static implicit operator bool(Duration duration)
    {
        return !(duration.hours == 0 && duration.minutes == 0 && duration.seconds == 0);
    }

    public static bool operator true(Duration duration)
    {
        return (duration.hours != 0 && duration.minutes != 0 && duration.seconds != 0);
    }

    public static bool operator false(Duration duration)
    {
        return (duration.hours == 0 && duration.minutes == 0 && duration.seconds == 0);
    }

    public static explicit operator DateTime(Duration duration)
    {
        return new DateTime(year:1, month:1, day:1,hour: duration.hours,minute:duration.minutes,second:duration.seconds);
    }


}