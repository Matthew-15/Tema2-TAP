In tema2 am aplicat principiile Solid in :
1. Single Responsability Principle(SRP):
>Clasa 'HotelReception' este responsabila de procesarea comenzilor, pe cand clasa 'UserInterface' se ocupa de interactiunea cu utilizatorul.
>Clasele 'RoomOrder','ProductOrder','BreakfastOrder' se ocupa de calculul pretului final.
2. Open/Closed Principle(OCP):
>Interfata 'IOrder' defineste metoda 'CalculateFinalPrice()' sistemul tine deschis prin adaugare de noi tipuri de comenzi.
>Adaugarea unui nou tip de comanda implica doar crearea unei noi clase care implementeaza interfata 'IOrder'.
3. Liskov Substition Principle(LSP):
>Fiecare clasa care implementeaza interfata 'IOrder' poate fi folosita in locul unei alte clase car implementeaza aceeasi interfata fara a afecta programul.Gen 'RoomOrder','ProductOrder','BreakfastOrder' pot fi folosite in cadrul procesului de comanda.
4. Interface Seregration Principle(ISP):
>Interfata 'IOrder' este mica si specifica ptr nevoile clientilor oferind o singura metoda 'CalculateFinalPrice()'ptr toate tipurile de comenzi.
>Fiecare tip de comanda implementeaza interfata 'IOrder' asigurand ca fiecare clasa depinde doar de metodele de care are nevoie.
5. Dependency Inversion Principle(DIP):
>In clasa 'HotelReception' dependentele sunt inversate prin injectarea dependentelor de procesare a comenzilor( de ex: 'RoomOrder','ProductOrder','BreakfastOrder') in loc sa fie instantiate direct in clasa.
>Clasa 'HotelReception' nu mai depinde de implementari concrete ptr procesarea comenzilor ,ci de abstractiuni.
