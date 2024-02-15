using masala1;

Pul pul = new Pul(236894);
PulOperator pulOperator = new PulOperator();
Pul.PulDelegate pulDelegate = new Pul.PulDelegate(pulOperator.UzsUsd);
pulOperator.Send(pul, "XalqBanki", pulDelegate);