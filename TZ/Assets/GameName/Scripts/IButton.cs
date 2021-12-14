

public interface IButton // Итерфейс "IButton" используется как схема в которой должет быть обязательно метод "PressButton"
{
    void PressButton(int numberButton); //Все кнопки, кроме кнопки "Start" содержат свой "numberButton".При нажатие на кнопку мы сможем узнать какая кнопка была нажата
    
}

/*Как устроен "numberButton"!
В сцене "LevelScene" "numberButton" имеет следующие значения:
"0" - EasyLevel
"1" - MiddleLevel
"2" - HardLevel
В сцене "GameScene"  "numberButton" имеет следующие значения:
"0" - ChangeLevelButton
"1" - RestartButton
 */