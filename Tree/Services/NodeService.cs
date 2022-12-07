using DataContracts;

namespace Services
{
    public class NodeService
    {
        public List<Node> getTree()
        {
            var tree = new List<Node>
            {
                new Node
                {
                    Id = 1,
                    Name = "Root",
                    Children = new List<Node>
                    {
                        new Node
                        {
                            Id = 2,
                            Name = "Node 2",
                            Children = new List<Node>
                            {
                                new Node
                                {
                                    Id = 4,
                                    Name = "Node 4",
                                    Children = new List<Node>
                                    {
                                        new Node
                                        {
                                            Id = 6,
                                            Name = "Node 6"
                                        }
                                    }
                                }
                            }
                        },
                        new Node
                            {
                                Id = 7,
                                Name = "Node 7"
                            },
                        new Node
                        {
                            Id = 3,
                            Name = "Node 3",
                            Children = new List<Node>
                            {
                                new Node
                                {
                                    Id = 5,
                                    Name = "Node 5"
                                }
                            }
                        }
                    }
                }
            };

            return tree;
        }

    }
}