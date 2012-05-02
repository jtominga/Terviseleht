using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace telBookService
{

    [ServiceContract]
    public interface ItelBookService
    {
        [OperationContract]
        bool submitkontakt(Contact kontakt);
        [OperationContract]
        List<Contact> getContacts(DAuth autenditav);
        [OperationContract]
        bool submitkasutaja(User user);
        [OperationContract]
        bool submitJagatudContact(SContact jagatudContact);
        [OperationContract]
        AuthData AutendiKasutaja(DAuth autenditav);
    }

    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    //public class telBookService : ItelBookService
    //{
    //    List<Contact> kontaktid = new List<Contact>();
    //    List<User> users = new List<User>();
    //    List<JagatudContact> jagatudContaktid = new List<JagatudContact>();

    //    public bool submitkontakt(Contact kontakt)
    //    {
    //        try
    //        {
    //            AuthPaisest(kontakt.authData);
    //            kontaktid.Add(mapDContactToDaoContact(kontakt));
    //        }
    //        catch (Exception)
    //        { return false; }
    //        return true;
    //    }

    //    public bool submitkasutaja(User user)
    //    {
    //        try
    //        {
    //            AuthPaisest(user.authData);
    //            users.Add(mapDUserToDaoUser(user));
    //        }
    //        catch (Exception)
    //        { return false; }
    //        return true;
    //    }

    //    public bool submitJagatudContact(SContact jagatudContact)
    //    {
    //        try
    //        {
    //            AuthPaisest(jagatudContact.authData);
    //            jagatudContaktid.Add(mapDSContactToDaoJagatudContact(jagatudContact));
    //        }
    //        catch (Exception)
    //        { return false; }
    //        return true;
    //    }

        //public AuthData AutendiKasutaja(DAuth autenditav)
        //{ return Autendi(autenditav.authData); }

        //private AuthData Autendi(AuthData autenditav)
        //{
        //    if (string.IsNullOrEmpty(autenditav.Username.ToString()) == false)
        //    {
        //        string KontUser = autenditav.Username.ToString();
        //        if (string.IsNullOrEmpty(autenditav.Passwordhash.ToString()) == false)
        //        {

        //            DBA.Baas.ProductionDataContext Ussr = new DBA.Baas.ProductionDataContext();
        //            var UUdre = from l in Ussr.Users
        //                        where l.Username.ToString() == autenditav.Username
        //                        select l;
        //            if (UUdre != null)
        //            {
        //                int Olemeid = UUdre.Count();
        //                if (Olemeid != 0)
        //                {
        //                    foreach (var l in UUdre)
        //                    {
        //                        if (l.Password == autenditav.Passwordhash.ToString())
        //                        {
        //                            autenditav.Isloggedin = true;
        //                            autenditav.Role = l.Role_fk;
        //                            return autenditav;
        //                        }
        //                    }
        //                }
        //            }

        //        }
        //    }
        //    return null;
        //}

        //private Contact mapDContactToDaoContact(Contact kontakt)
        //{
        //    Contact newContact = new Contact();
        //    newContact.Aadress = kontakt.address;
        //    newContact.E_mail = kontakt.email;
        //    newContact.Eesnimi = kontakt.firstName;
        //    newContact.Perenimi = kontakt.lastName;
        //    newContact.Telefon = kontakt.tel;
        //    newContact.Skype = kontakt.skype;
        //    newContact.Loodud = DateTime.Now;
        //    //TODO!!!
        //    //newContact.User_fk = kontakt.submitter;
        //    return newContact;
        //}

        //private User mapDUserToDaoUser(User kasutaja)
        //{
        //    User newUser = new User();
        //    newUser.Username = kasutaja.Username;
        //    newUser.Password = kasutaja.Password;
        //    newUser.E_mail = kasutaja.Email;
        //    newUser.Loodud = DateTime.Now;
        //    return newUser;
        //}

        //private JagatudContact mapDSContactToDaoJagatudContact(SContact jagatudContact)
        //{
        //    JagatudContact newUser = new JagatudContact();
        //    newUser.ContactID = jagatudContact.ContactID;
        //    newUser.UserID = jagatudContact.UserID;
        //    newUser.AlgusKP = jagatudContact.AlgusKP;
        //    newUser.LoppKP = jagatudContact.LoppKP;
        //    return newUser;
        //}

        //private AuthData AuthPaisest(AuthData authenditav)
        //{
        //    AuthData tulem = Autendi(authenditav);
        //    if (tulem == null)
        //    {
        //        throw new Exception("Authentimine ebaonnetsus.");
        //    }
        //    return tulem;
        //}

        //public List<Contact> getContacts(DAuth authData)
        //{
        //    AuthData autenditudKasutaja = null;
        //    try
        //    {
        //        autenditudKasutaja = AuthPaisest(authData.authData);
        //    }
        //    catch (Exception)
        //    { return null; }

        //    return kontaktid;
        //}


    //}
}
