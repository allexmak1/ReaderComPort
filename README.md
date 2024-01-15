# ReaderComPort

Desctop приложение на C#(WinForms) для чтения и отправки 6 байтных сообщений в COM порт.

![Screnshot](https://github.com/allexmak1/ReaderComPort/blood/main/image/image.png)

## FAQ

Приложение настроенно на скорость 115200.
При выборе порта подключения происходит поиск подключенных и выводит их список в comboBox.
Максимальная длинна приема и отправки сообщения 6 байт.
Валидация ввода данных по разделителю ""," ", "-", "\_":
FF FF FF FF FF FF
FFFFFFFFFFFF
FF-FF-FF-FF-FF-FF
FF_FF_FF_FF_FF_FF
При неверности выводит окно ошибки.

allexmak, 2024
