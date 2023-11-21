namespace Api.Swagger.Services;

/// <summary>
/// Сервис инкрементного подсчета.
/// </summary>
public class CountIncrementService : ICountService
{
    private int _count = 0;

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int Count => ++_count;
}
