#Zdravotné stredisko
V Nalomenej Trieske majú zdravotné stredisko.V tomto zimnom období doňho prichádza veľa pacientov.Dennodenne si niekto vytkne členok alebo zlomí nohu. V škole vyhlásili chrípkové prázdniny.Hrozí chrípková epidémia.Aj choroba šialených tiav vyčíňa ako besná...

V zdravotnom stredisku na pohotovosti nepretržite ordinuje jeden doktor.Čakáreň plná a noví pacienti prichádzajú a prichádzajú... A každému treba pomôcť – ale komu skôr? Na tejto pohotovosti to riešia tak, že vždy, keď doktor ošetrí jedného pacienta, sestrička zavolá z čakárne dnu toho, kto vyzerá byť najviac chorý. (Ak je takých pacientov viac, tak toho z nich, ktorý čaká najdlhšie.)

Tvojou úlohou je spraviť simuláciu zdravotného strediska.Na začiatku je čakáreň prázdna.Tvoj program má postupne spracovávať tieto príkazy:

"pacient cislo stav" – do čakárne prišiel nový pacient, jeho evidenčné číslo je cislo a číslo stav udáva, ako chorý tento pacient vyzerá(čím je väčšie, tým viac je pacient chorý). Obe čísla sú nezáporné celé a neprevyšujú 1 000 000 000.
"dalsi" – do ordinácie má ísť ďalší pacient.
"koniec" – na dnes končíme, odteraz má službu pohotovosť na opačnom konci mesta, presuňte sa tam.
##Vstup

Vstup obsahuje niekoľko riadkov, v každom z nich je jeden z vyššie popísaných príkazov. Môžeš predpokladať, že žiadni dvaja pacienti nemajú rovnaké evidenčné číslo. Príkazov bude vo vstupnom súbore najviac 250 000.

Pozor! Niektoré testovacie vstupy sú veľké.Riešenia v C++, ktoré používajú cin a cout, ich možno nestihnú v časovom limite načítať.Používajte namiesto toho funkcie scanf a printf.

##Výstup

Vždy, keď prečítaš zo vstupu príkaz dalsi, vypíš jeden riadok a v ňom evidenčné číslo pacienta, ktorý sa práve dostal do ordinácie.V prípade, že je čakáreň práve prázdna, namiesto čísla pacienta vypíš -1.

##Príklad

###vstup
dalsi
pacient 1 10
pacient 2 2
pacient 3 5
dalsi
pacient 17 0
pacient 999 100
dalsi
pacient 13 5
dalsi
koniec

###výstup
-1
1
999
3

##Vysvetlenie

Keď doktor volá posledného pacienta, sú v čakárni dvaja rovnako chorí pacienti (s číslami 3 a 13). Do ordinácie ide pacient číslo 3, lebo čaká dlhšie.