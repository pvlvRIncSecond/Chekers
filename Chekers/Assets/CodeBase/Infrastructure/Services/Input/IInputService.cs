using UnityEngine;

namespace CodeBase.Infrastructure.Services.Input
{
    public interface IInputService : IService
    {
        public Controll Controll { get; }
        int TouchCount { get; }
        Vector2 TouchPosValue0 { get; }
        Vector2 TouchPosValue1 { get; }
        Vector2 TouchDeltaValue0 { get; }
        Vector2 TouchDeltaValue1 { get; }
    }
}