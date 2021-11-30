// See https://aka.ms/new-console-template for more information
using Week1.Agenzia.Client;
using Week1.Agenzia.Core.Entities;

//Si vuole progettare un’applicazione in grado di gestire un’agenzia immobiliare.
//Gli immobili sono caratterizzati da un identificativo numerico, indirizzo, cap, città, da una superficie espressa in mq attraverso
//un numero intero e da un flag disponibile/non disponibile.
//L’agenzia gestisce diverse tipologie di immobili: Box, Appartamenti e Ville.

//Per i box è riportato il numero di posti auto.
//Per gli appartamenti è riportato il numero di vani e il numero di bagni, e per le ville è previsto, in aggiunta
//rispetto all’appartamento, la dimensione in mq del giardino.

//Per gli immobili è necessario definire un metodo che restituisca, in un formato stringa a piacere, il
//tipo di immobile e tutte le proprietà.

//Realizzare un programma che all'accesso consente all'utente di:

//  1   -Visualizzare tutti gli immobili
//      Il risultato della ricerca è visualizzato a video stampando la scheda degli immobili.

//  2   -Visualizzare gli immobili con una superficie maggiore di...
//      (Chiedere all'utente i mq. Filtrare gli immobili con superficie maggiore di quella scelta dall'utente)

//  3   - Visualizzare gli immobili disponibili all'acquisto/affitto

//  4   - Mostrare gli immobili di una certa categoria

//  5   - Inserire un nuovo immobile
//          (Chiedere all'utente le informazioni sull'immobile e aggiungere il nuovo immobile.
//          Il nuovo immobile che viene aggiunto sarà inizialmente disponibile. Quando aggiungo un nuovo immobile
//          incremento di 1 l'id rispetto all'ultimo id in lista)

//  6   - Eliminare un immobile.
//         (Chiedere all'utente quale immobile vuole eliminare (esempio: input id) e eliminarlo).

//  7   - Modificare lo stato di un immobile in 'Non disponibile' se è stato venduto/affittato.

//Terminata un'operazione l'utente deve poter eseguire una nuova scelta,
//a meno che non decida di terminare.


Menu.Start();
