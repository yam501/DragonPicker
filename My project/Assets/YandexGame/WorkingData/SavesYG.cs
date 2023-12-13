﻿
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;
        

        // Ваши сохранения

        public int score;
        public int bestScore = 0;
        public string[] achivment;
    }
}
