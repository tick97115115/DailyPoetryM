namespace DailyPoetryM.Services;

public interface IPreferenceStorage
{
    int Set(string key, int value);
    int Get(string key, int defaultValue);
}