using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: Users
        public ActionResult Index()
        {
            return View(userlist);
        }
 
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // This method is responsible for displaying the details of a user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Details view.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // You can modify this code to fit your specific requirements.
            
            User user = userlist.FirstOrDefault(u => u.Id == id);
            
            if (user == null)
            {
            return HttpNotFound();
            }
            
            return View(user);
        }
 


        // GET: User/Create
        public ActionResult Create()
        {
            // This method is responsible for displaying the view to create a new user.
            // It simply returns the Create view, which contains the form to input user information.
            return View();
        }
 
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // This method is responsible for handling the HTTP POST request to create a new user.
            // It receives user input from the form submission and adds the new user to the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If an error occurs during the process, it returns the Create view to display any validation errors.

            if (ModelState.IsValid)
            {
            // Add the new user to the userlist
            userlist.Add(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
            }

            // If there are validation errors, return the Create view with the user object
            return View(user);
        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User updatedUser)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
            // Update the user's information
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
            }

            // If there are validation errors, return the Edit view with the updatedUser object
            return View(updatedUser);
        }
 
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User updatedUser)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
            // Update the user's information
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
            }

            // If there are validation errors, return the Edit view with the updatedUser object
            return View(updatedUser);
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // This method is responsible for displaying the view to delete an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Delete view.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // This method is responsible for handling the HTTP POST request to delete an existing user with the specified ID.
            // It receives the ID of the user to be deleted and removes it from the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            // Remove the user from the userlist
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }
 
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // This method is responsible for handling the HTTP POST request to delete an existing user with the specified ID.
            // It receives the ID of the user to be deleted and removes it from the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.

            User user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
            return HttpNotFound();
            }

            // Remove the user from the userlist
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }
    }
}
