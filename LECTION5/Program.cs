﻿// Код чаще читается, чем пишется!
// Старайтесь не использовать сокращения, кроме тех,  что приняты в разрабатываемых продуктах.
// В сишарп не используют нижнее подчеркивание.
// Не сокращать слова в нейминге.
// Используйте универсальные имена платформы.
// Использовать общие не привязанные к контексту имена.
// Именование методов, аргументов, переменных есть свои правила наименования.
// Читать гайды по конкретному языку.
// Использование нотаций.
// Избегать  длинных строк.

// проверка типа данных
// int a = 12;
// Console.WriteLine(a.GetType().Name);

using System.Linq;
var a = 12;
// Console.WriteLine(a.GetType());

var data = new int[] {1, 2, 3, 4}
            .Where(e=> e>0)
            .Select(e=> new {q = e, w = e+1});
Console.WriteLine(data.GetType());

