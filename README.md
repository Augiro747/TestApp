## Тестовое задание на вакансию Junior Разработчик C# .Net

[Ссылка на тестовое задание](https://versta24.ru/hr/testfordevjun)

### Описание задачи
Реализовать простое Web приложение для приемки заказа на доставку со следующим функционалом:

1. Форма создания нового заказа (все поля обязательны для заполнения):

  * Город отправителя
  * Адрес отправителя
  * Город получателя
  * Адрес получателя
  * Вес груза
  * Дата забора груза

2. Форма отображения списка заказов: все созданные заказы должны отображаться в отдельной форме. Помимо полей, введенных пользователем при создании заказа, должен отображаться автоматически сгенерированный номер заказа.

3. Форма просмотра созданного заказа в режиме чтения. Должна открываться при клике на заказ в списке заказов.

### Требования

Необходимы база данных [SQL Server Express LocalDB](https://learn.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16) и среда выполнения [ASP.NET Core 7](https://learn.microsoft.com/ru-ru/dotnet/core/install/windows?tabs=net70).

### Запуск

Запуск предлагается производить при помощи windows powershell на системе Windows 11. Для запуска необходимо перейти в powershell в директорию с приложением и прописать ```dotnet run Program.cs```, затем необходимо скопировать строку с портом ```http://localhost:xxxx``` и вставить в адресную строку браузера.
