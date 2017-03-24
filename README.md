SpaceShape consiste nel conquistare in più fretta possibile un territorio, il territorio è formatto da tanti quadrati. Quindi ad aumentare il numero dei quadrati conquistati aumenterà anche il territorio conquistato.  
 
Come si conquista un quadrato? 
	Un quadrato si dice conquistato se il perimetro di tale quadrato viene percorso da un solo giocatore. 
 
Livelli: 
	Il gioco non prevede un livello finale, ma infiniti livelli. I livelli non rappresentano un traguardo ma la potenza del giocatore. (ad esempio: se sono di livello 5 sono più potente di quello del livello 4). Ogni giocatore parte necessariamente dal livello 0 (zero). 
 
	Come si passa da un livello all'altro?  
		Partenza livello giocatore è 0, ha un quadrato e una regina; 
		Deve conquistare       1  quadrato per salire al 1° livello (Tot quadrati: 1 ); 
		Deve conquistare altri 2  quadrati per salire al 2° livello (Tot quadrati: 3 ); 
		Deve conquistare altri 3  quadrati per salire al 3° livello (Tot quadrati: 6 ); 
		Deve conquistare altri 5  quadrati per salire al 4° livello (Tot quadrati: 11); 
		Deve conquistare altri 8  quadrati per salire al 5° livello (Tot quadrati: 19); 
		Deve conquistare altri 13 quadrati per salire al 6° livello (Tot quadrati: 32); 
 
	Quindi la formula per salire di livello n è la somma tra i quadrati necessari per salire di livello (n-1) e la somma tra i quadrati necessari per salire di livello (n-2). 
 
Il personaggio principale: 
	Non c'è un protagonista specifico in questo gioco, ma tutti sono protagonisti. 
 
I controlli del giocatore: 
	Che cosa può fare il giocatore? 
		Conquistare i quadrati; 
		Comprare items; 
		Scambiare i propri quadrati conquistati con gli items. 
	Ad esempio: 
	Ho conquistato 100 quadrati, l'items che mi rende i quadrati indistruttibili per 10 ore costa 1€ oppure 10 quadrati.  

Interagire con altri giocatori: 
	Allearsi con altri giocatori, massimo 3 giocatori per alleanza; 
	Distruggere quadrati altri tramite items. 
 
Il ciclo del gioco: (Start,  Game Over, Restart) 
	Start: Nuova partita e si parte dal livello 0, 
	Game Over: Quando muore la regina, 
	Restart: Riparte da Start, 
	Pausa: Il gioco non va mai in pausa. 
 
Collezione di cose:  
	Gli items una volta comprati hanno una certa data di scadenza, la data di scadenza è piuttosto lunga. 

Tipi di items principali: 
	Muro: rende i quadrati di muro indistruttibile per 8h/4h/2h/1h/30min ; 
	Pistola: attacca l'altro giocatore cercandoli di rubare i quadrati. 
	Ci saranno diversi tipi di pistola. 
 
Ostacoli che uccidono il giocatore: 
	Giocatore A che cerca di uccidere giocatore B, tramite items; 
	Dopo 5 minuti che non conquista almeno 1 quadrato ne perde 1. 
 
Grafica Interfaccia utente: 
	A cura di Jaco; 
 
Memorizzazione informazioni giocatore: 
	Il gioco non viene memorizzato, è sempre in continua evoluzione. 
 
Modalità giocatore: 
	Multiplayer: è la modalità standart; 
	Single player: il pc deve simulare tanti giocatori.  

# prj