namespace Api.Swagger.Services;

/// <summary>
/// Предоставляет интерфейс подсчета.
/// </summary>
public interface ICountService
{
    /// <summary>
    /// Возвращает число.
    /// </summary>
    int Count { get; }
}
