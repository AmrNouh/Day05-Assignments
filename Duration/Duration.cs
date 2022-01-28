// handling ToString() Formats
// Try operator overloading
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
        if (obj is Duration)
        {
            Duration duration = (Duration)obj;
            return (hours == duration.hours && minutes == duration.minutes && seconds == duration.seconds);
        }
        else
        {
            return false;
        }
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
        return new DateTime(year: 1, month: 1, day: 1, hour: duration.hours, minute: duration.minutes, second: duration.seconds);
    }


}