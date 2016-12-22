#ZADANIE

Na vstupe je N bodov s celočíselnými súradnicami. Tvojou úlohou je vypočítať, koľko existuje rôznych konvexných štvoruholníkov
(Štvoruholník je konvexný práve vtedy, keď každý jeho vnutorný uhol je menší ako 180◦), ktorých vrcholy tvoria niektoré štyri z týchto bodov.

Hint. Snažte sa vymyslieť a napísať program, ktorý zaráta každý hľadaný objekt len raz – takýto program zvykne byť k-krát rýchlejší od programu, ktorý zaráta každý objekt k-krát.

Vstup
V prvom riadku je počet bodov N (0 <= N <= 70). V každom z nasledujúcich N riadkov sú súradnice jedného bodu. Všetky súradnice ležia v rozmedzí od -10,000 do 10,000.

Výstup

Vypíš jeden riadok s výsledkom.

Príklady1:
IN:
5
0 0
6 0
0 6
6 6
5 3


OUT:
3

Príklady2:
IN:
6
0 0
0 1
1 0
1 1
2 0
2 1

OUT:
9