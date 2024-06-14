using System.Data;
using Model;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");

    // Create
    // Console.WriteLine("Indsæt et nyt task");
    // db.Add(new TodoTask("En opgave der skal løses", "Lav det nu",  false, ));
    // db.SaveChanges();

    // Create
    // Console.WriteLine("Indsæt et nyt task");
    //db.Add(new TodoTask("En opgave der skal løses", "Lav det nu", false, ));
    // db.SaveChanges();

    // Create User
    // Console.WriteLine("Opretter ny bruger");
    // db.Add(new User("Søren", 43));
    // db.SaveChanges();

    // Create
    // Console.WriteLine("Indsæt et nyt task");
    // db.Add(new TodoTask("En opgave der skal løses", false));
    // db.SaveChanges();

    // Read
    Console.WriteLine("Find det sidste task");
    var lastTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    Console.WriteLine($"Text: {lastTask.Text}");
    /*
    // Update
    Console.WriteLine("Opdater det sidste task");

    // Find the last task again (just for demonstration purposes)
    var taskToUpdate = db.Tasks
        .OrderByDescending(b => b.TodoTaskId)
        .First();

    // Modify the task
    taskToUpdate.Text = "Opdateret opgave";

    // Save changes to the database
    db.SaveChanges();
   
    // Update
Console.WriteLine("Opdater den første task");

// Find the first task
var firstTask = db.Tasks
    .OrderBy(b => b.TodoTaskId)
    .First();

// Modify the task
firstTask.Text = "Opdateret første opgave";

// Save changes to the database
db.SaveChanges();

    
    // Assume you have a variable with the ID of the task you want to update
    int taskIdToUpdate = 8; // Replace with the actual ID of the task you want to update

    // Update
    Console.WriteLine($"Opdaterer task med ID {taskIdToUpdate}");

    // Find the task by its ID
    var taskToUpdate = db.Tasks.FirstOrDefault(t => t.TodoTaskId == taskIdToUpdate);

    if (taskToUpdate != null)
    {
        // Modify the task (for example, updating its Text property)
        taskToUpdate.Text = "Ny opdateret tekst";

        // Save changes to the database
        db.SaveChanges();

        Console.WriteLine($"Task med ID {taskIdToUpdate} er blevet opdateret");
    }
    else
    {
        Console.WriteLine($"Kunne ikke finde task med ID {taskIdToUpdate}");
    }

    
    // Delete
    Console.WriteLine("Slet det sidste task");

    // Find the last task again (just for demonstration purposes)
    var taskToDelete = db.Tasks
        .OrderByDescending(b => b.TodoTaskId)
        .First();

    // Delete the task
    db.Remove(taskToDelete);

    // Save changes to the database
    db.SaveChanges();
   

    // Find den første task baseret på et kriterium, f.eks. den mindste TodoTaskId
    var taskToDelete = db.Tasks.OrderBy(t => t.TodoTaskId).FirstOrDefault();

    if (taskToDelete != null)
    {
        // Slet opgaven fra databasen
        db.Tasks.Remove(taskToDelete);
        db.SaveChanges();

        Console.WriteLine($"Første task med ID {taskToDelete.TodoTaskId} er blevet slettet");
    }
    else
    {
        Console.WriteLine("Ingen tasks fundet til sletning");
    }
    db.SaveChanges();
    

    // Angiv ID'et for den task, du ønsker at slette
    int taskIdToDelete = 8; // Eksempel på ID, du ønsker at slette

    // Find tasken baseret på det valgte ID
    var taskToDelete = db.Tasks.FirstOrDefault(t => t.TodoTaskId == taskIdToDelete);

    if (taskToDelete != null)
    {
        // Slet opgaven fra databasen
        db.Tasks.Remove(taskToDelete);
        db.SaveChanges();

        Console.WriteLine($"Task med ID {taskToDelete.TodoTaskId} er blevet slettet");
    }
    else
    {
        Console.WriteLine($"Task med ID {taskIdToDelete} blev ikke fundet i databasen");
    }
    */
    /*
    // Update
    // Assume you have the ID of the task you want to update
    int taskIdToUpdate = 11; // Replace with the actual ID of the task you want to update

    // Find the task by its ID
    var taskToUpdate = db.Tasks.FirstOrDefault(t => t.TodoTaskId == taskIdToUpdate);

    if (taskToUpdate != null)
    {
        // Add or update the category for the task
        taskToUpdate.category = "Ny kategori";

        // Save changes to the database
        db.SaveChanges();

        Console.WriteLine($"Task med ID {taskIdToUpdate} er blevet opdateret med en ny kategori");
    }
    else
    {
        Console.WriteLine($"Kunne ikke finde task med ID {taskIdToUpdate}");
    }
    */
}