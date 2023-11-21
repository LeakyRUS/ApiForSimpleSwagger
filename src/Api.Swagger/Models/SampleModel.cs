namespace Api.Swagger.Models;

/// <summary>
/// Простая модель, содержащая сообщение и рандомное число.
/// </summary>
/// <param name="Message">Сообщение.</param>
/// <param name="RandomNumber">Число из <see cref="Random"/>.Shared.Next().</param>
public record SampleModel(string Message, int RandomNumber);
