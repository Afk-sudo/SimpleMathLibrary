# SimpleMathLibrary - Простоя математическая библиотека

### Оглавление:
- Структура репозитория.
- Подключение библиотеки.
- API.

## Структура репозитория.
В корне репозитория выделено 2 каталога **DLL** и **SimpleMathLibrarySolution**. 
В первом находится скомпилированная dll библиотека.
Во втором исходный код библиотеки.

## Подключение библиотеки.

1.Скачайте архив репозитория.

2.Распакуйте архив.

3.В своем проекте добавьте ссылку на **SimpleMathLibrary.dll**


## API.
Все методы представленные в библиотеке являются статичными. К методам 

- double **Add(double a, double b)** - складывает два числа

- double **Subtract(double a, double b)** - вычитает второе число из первого, возвращаемый тип double

- double **Multiply(double a, double b)** - умножает первое число с вторым

- double **Split(double a, double b)** - делит 1 число на второе число

- double **CalculateLapArea(double lapRadius)** - расчет площади круга

- double **CalculateSquareArea(double sideLengthSquare)** - расчет площади квадрата

- double **CalculateParallelogramArea(double baseParallelogram, double heightParallelogram)** - расчет площади параллелограмма
