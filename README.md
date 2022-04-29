# SZTF1HF0016_ZRSTHS
Egy kétdimenziós rácson szeretnénk a robotunk mozgását tesztelni. Kezdetben a robot a [0, 0]
pozícióban található és az északi irányba néz. A teszteléshez az alábbi (U) utasításokat állnak
rendelkezésre:
- "." a robot egy lépést tesz előre a jelenlegi irányba,
- "<" a robot elfordul 90 fokkal az óramutató járásával ellentétes irányba,
- ">" a robot elfordul 90 fokkal az óramutató járásával megegyezően.
A feladat, hogy feldolgozza az utasítások sorozatát és megmondja a robot végső pozícióját.

Bemenet (Fájl)
- egyetlen fájl, aminek a neve: input.txt
- a fájl felépítése:
- egyetlen sor, az U utasítások sorozata
Kimenet (Fájl)
- egyetlen fájl, aminek a neve: output.txt
- egyetlen sor, ami a robot végső pozíciója [X, Y ] formában
Megkötés(ek)
- 0 ≤ U utasítások száma ≤ 10 000
- minden karakter az U-ban, Ui ∈ {. <>}
- a robot minden esetben a [0, 0] pozícióból indul
