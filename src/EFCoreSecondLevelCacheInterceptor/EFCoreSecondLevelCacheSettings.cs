using System;

namespace EFCoreSecondLevelCacheInterceptor;

/// <summary>
///     Global Cache Settings
/// </summary>
public class EFCoreSecondLevelCacheSettings
{
    /// <summary>
    ///     The selected cache provider
    /// </summary>
    public Type CacheProvider { get; set; } = default!;

    /// <summary>
    ///     Selected caching provider name
    /// </summary>
    public string ProviderName { get; set; } = default!;

    /// <summary>
    ///     Is an instance of EasyCaching.HybridCache
    /// </summary>
    public bool IsHybridCache { get; set; }

    /// <summary>
    ///     Gets or sets the cache key prefix.
    ///     Its default value is `EF_`.
    /// </summary>
    /// <value>The cache key prefix.</value>
    public string CacheKeyPrefix { get; set; } = "EF_";

    /// <summary>
    ///     CacheAllQueries Options
    /// </summary>
    public CacheAllQueriesOptions CacheAllQueriesOptions { get; set; } = new();

    /// <summary>
    ///     Cache Specific Queries Options
    /// </summary>
    public CacheSpecificQueriesOptions CacheSpecificQueriesOptions { get; set; } = new(null);

    /// <summary>
    ///     Cachable Queries Options
    /// </summary>
    public CachableQueriesOptions CachableQueriesOptions { get; set; } = new();

    /// <summary>
    ///     Skip Cache Specific Queries Options
    /// </summary>
    public SkipCacheSpecificQueriesOptions SkipCacheSpecificQueriesOptions { get; set; } = new(null);

    /// <summary>
    ///     Should the debug level logging be disabled?
    /// </summary>
    public bool DisableLogging { set; get; }

    /// <summary>
    ///     Here you can decide based on the correct executing SQL command, should we cache its result or not?
    /// </summary>
    public Predicate<string>? SkipCachingCommands { set; get; }

    /// <summary>
    ///     Here you can decide based on the correct executing SQL command, should we invalidate the cache or not?
    /// </summary>
    public Predicate<string>? SkipCacheInvalidationCommands { set; get; }

    /// <summary>
    ///     Here you can decide based on the correct executing result, should we cache this result or not?
    /// </summary>
    public Predicate<(string CommandText, object Value)>? SkipCachingResults { set; get; }
}