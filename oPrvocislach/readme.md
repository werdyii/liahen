#Zadanie
Rasťo sa prednedávnom v jednej knižke dočítal, že prvočísel je nekonečne veľa...ale už o dve strany neskôr sa dozvedel aj to, že existujú ľubovoľne dlhé úseky po sebe idúcich prirodzených čísel, medzi ktorými nie je ani jedno prvočíslo.A ked na dôvažok zistil, že Bertrandov postulát hovorí, že pre každé N je medzi N a 2N aspoň jedno prvočíslo, mal v tom už dokonalý zmätok.Pomohol by mu program, ktorý by vedel pre zadané intervaly hovoriť, koľko prvočísel vlastne obsahujú.

##Vstup
Na prvom riadku vstupu je jedno celé číslo T(1≤ T ≤ 20) – počet intervalov, ktoré budú nasledovať.
Nasleduje T riadkov, v i-tom z nich sú 2 celé čísla a_i, b_i (1 ≤ a_i ≤ b_i ≤ 1 000 000).

##Výstup
Výstup by mal obsahovať T riadkov, na i-tom z nich jedno celé číslo – počet prvočísel, ktoré ležia medzi a_i a b_i(vrátane).

##Poznámky
Prvočíslo je prirodzené číslo, ktoré má práve dvoch deliteľov(jednotku a seba samého). Najmenšie prvočísla sú teda 2, 3, 5, 7, 11, ...
Snaž sa, aby tvoj program bol čo najrýchlejší.Nerátaj zbytočne viackrát to isté.Zbytočne pomalé programy nemusia stihnúť skončiť v časovom limite.

###IN
3
3 5
122 125
340000 350000

###OUT:
2
0
795