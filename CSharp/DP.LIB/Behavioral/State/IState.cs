namespace DP.LIB.Behavioral;

public interface IState
{
  public void NextState();
}



public class Email
{

  private IState state;
  public Email ()
  {
    state = new NewEmailState(this);
  }
  public void MoveToNextState()
  {
    state.NextState();
  }

public abstract class EmailState:IState
{
  protected Email mail;
  public EmailState(Email e)
  {
    mail=e;
  }
    public abstract void NextState();
}

private class NewEmailState : EmailState
{
    public NewEmailState (Email e):base(e)
    {
    }

    public override void NextState()
    {
      Console.WriteLine("new to sending");
      mail.state=new SendingEmailState(base.mail);
    }
}

private class SendingEmailState : EmailState
{
    public SendingEmailState (Email e):base(e)
    {
    }
    public override void NextState()
    {
      Console.WriteLine("sending to sent");
      mail.state=new SentEmailState(base.mail);
    }
}

private class SentEmailState : EmailState
{
    public SentEmailState (Email e):base(e)
    {
    }
    public override void NextState()
    {
      Console.WriteLine("Already sent");
      //done nothing to do when sent
    }
}
  
}
