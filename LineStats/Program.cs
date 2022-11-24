using LineStats;

/*
 * 1: Kort intro til eksempel
 * 2: Repetisjon - skrive om til interface - dependency injection
 * 3: Vise alternative kilder
 * 4: Teste med manuell mock
 * 5: Teste med Moq-rammeverk
 */

//var stats = LineStatsService.Count("TextFile1.txt", "ER");
//var reader = new FileLineReader("TextFile1.txt");
//var reader = new KeyboardLineReader();

var reader = new WebLineReader("https://www.vg.no");
var service = new LineStatsService(reader);
var stats = service.Count("ER");
Console.WriteLine(stats);

