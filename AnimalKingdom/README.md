```mermaid
classDiagram
    class Animal {
        <<abstract>>
        +Sound()
    }
    class Cat {
        +Sound()
    }
    class Dog {
        +Sound()
    }
    Animal <|-- Cat
    Animal <|-- Dog
```
