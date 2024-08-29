using System.Collections.Generic;
using BehaviorTree;

public class GuardBT : Tree
{

    protected override Node SetupTree()
    {
        Node root = new Selector(new List<Node>
        {

            //branch to survive
            new Selector(new List<Node>
            {

                //branch to retreat
                new Selector(new List<Node>
                {
                    //take cover
                    new Sequence(new List<Node>
                    {
                        new CheckHealthAmount(),
                        new CheckCover(),
                        new TaskTakeCover(),
                        new TaskHeal(),
                    }),

                    //run away
                    new Sequence(new List<Node>
                    {
                        new CheckHealthAmount(),
                        new Invertor(new CheckCover()),
                        new TaskRunAway(),
                    }),
                }),

                //branch for healing
                new Sequence(new List<Node>
                {
                    new CheckHealthAmount(),

                    //uses healing
                    new Sequence(new List<Node>
                    {
                        new CheckHealingItem(),
                        new TaskHeal(),
                    }),

                    new Selector(new List<Node>
                    {
                        //goes to healing item
                        new Sequence(new List<Node>
                        {
                            new CheckHealthAmount(),
                            new CheckKnowledgeOfHealing(),
                            new TaskGoToTarget(),
                        }),

                        //finds healing items
                        new Sequence(new List<Node>
                        {
                            new CheckHealthAmount(),
                            new Invertor(new CheckKnowledgeOfHealing()),
                            new TaskFindHealing(),
                        }),
                    }),

                }),

            }),

            //branch to engage
            new Selector(new List<Node>
            {

                //attack enemy
                new Sequence(new List<Node>
                {
                    new CheckEnemyInAttackRange(),
                    new TaskAttack(),
                }),

                //move towards enemy
                new Sequence(new List<Node>
                {
                    new CheckEnemyInFOVRange(),
                    new TaskGoToTarget(),
                }),

                //finds enemy
                new Sequence(new List<Node>
                {
                    new Invertor(new CheckEnemyInFOVRange()),
                    new CheckKnowledgeOfEnemy(),
                    new TaskFindEnemy(),
                }),

            }),

            //default task
            new TaskPatrol(),
        });

        return root;
    }
}