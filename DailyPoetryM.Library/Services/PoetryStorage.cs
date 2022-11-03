using DailyPoetryM.Models;
using System.Linq.Expressions;

namespace DailyPoetryM.Services;

public class PoetryStorage : IPoetryStorage
{
    private readonly IPreferenceStorage _preferenceStorage;

    public PoetryStorage(IPreferenceStorage preferenceStorage)
    {
        _preferenceStorage = preferenceStorage;
    }

    public bool IsInitialized => 
        _preferenceStorage.Get(PoetryStorageConstant.VersionKey, 0) == PoetryStorageConstant.Version;

    public Task<IEnumerable<Poetry>> GetPoetriesAsync(Expression<Func<Poetry, bool>> where, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Poetry> GetPoetryAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }
}

public static class PoetryStorageConstant
{
    public const int Version = 1;
    public const string VersionKey = nameof(PoetryStorageConstant) + "." + nameof(Version);
}