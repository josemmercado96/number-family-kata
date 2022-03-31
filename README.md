# number-family-kata

You’re given a list of pairs that represent direct relationships between 2 persons.
Each pair means that these persons are directly related. For example:

    {
        “john”, “jane”
        “john”, “peter”
        “john”, “samuel”
        “peter”, “mark”
        “mark”, “sasha”
        “kirk”, “tom”
        “tom”, “erica”
    }

All the people that are related (directly or indirectly) make part of the same family.
In the example above there are 2 families:

- John has relation with Jane, Peter, Samuel, then Peter has relation with Mark and Mark with Sasha.
- Kirk has relation with Tom and Tom has relation with Erica
