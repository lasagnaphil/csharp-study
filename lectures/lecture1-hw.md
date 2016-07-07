# Lecture 1 Homework : 하노이 그리기

- 구현해야 하는 함수: ``DrawHanoi(int n, int[] towerA, int[] towerB, int[] towerC)``

- n : 원판의 개수
- towerA: 타워 A에 있는 원판들
- towerB: 타워 B에 있는 원판들
- towerC: 타워 C에 있는 원판들

- 샘플 출력 결과:

```csharp
n = 5
towerA = {5, 4, 3, 2, 1}
towerB = {0, 0, 0, 0, 0}
towerC = {0, 0, 0, 0, 0}
```
output:
```
     |               |               |
    *|*              |               |
   **|**             |               |
  ***|***            |               |
 ****|****           |               |
*****|*****          |               |
```

```csharp
n = 5
towerA = {5, 4, 0, 0, 0}
towerB = {2, 1, 0, 0, 0}
towerC = {3, 0, 0, 0, 0}
```
output:
```
     |               |               |
     |               |               |
     |               |               |
     |               |               |
 ****|****          *|*              |
*****|*****        **|**          ***|***
```
