using Third;

MyCollection myCollection = new MyCollection();

Student student = new Student();

myCollection.Add(student);
myCollection.Add(new Student());
myCollection.Add(new Pensioner());
myCollection.Add(new Pensioner());

myCollection.Delete(0);

myCollection.Show();

