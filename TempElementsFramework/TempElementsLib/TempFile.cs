using System;
using TempElementsLib.Interfaces;

namespace TempElementsLib
{
    public class TempFile : ITempFile
    {
        private bool disposedValue;

        public TempFile()
        {
        }

        public string FilePath => throw new NotImplementedException();

        public bool IsDestroyed => throw new NotImplementedException();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Wyczyścić stan zarządzany (obiekty zarządzane)
                }

                // TODO: Zwolnić niezarządzane zasoby (niezarządzane obiekty) i przesłonić finalizator
                // TODO: Ustawić wartość null dla dużych pól
                disposedValue = true;
            }
        }

        // // TODO: Przesłonić finalizator tylko w sytuacji, gdy powyższa metoda „Dispose(bool disposing)” zawiera kod służący do zwalniania niezarządzanych zasobów
        // ~TempFile()
        // {
        //     // Nie zmieniaj tego kodu. Umieść kod czyszczący w metodzie „Dispose(bool disposing)”.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Nie zmieniaj tego kodu. Umieść kod czyszczący w metodzie „Dispose(bool disposing)”.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
