using System.Web;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/v1/requests/events/">event</see> input object.
    /// </summary>
    public class RequestEventCreateInput
    {
        private readonly Dictionary<string, string> eventRequestFields = new();

        /// <summary>
        /// Get the HTTP event API request parameters.
        /// </summary>
        public string HttpRequestParameters
        {
            get => string.Join("&", eventRequestFields.Select(x => x.Key + "=" + x.Value).ToArray());
        }

        /// <summary>
        /// Used to specify an option in the Category field of the request.
        /// </summary>
        /// <param name="requestCategory">The request category.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Category(RequestCategory requestCategory) 
        {
            AddToEventRequestFields("category", requestCategory.GetEnumMemberValue());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the configuration item that is to be related to the request.</br>
        /// <br>The configuration item needs to be identified by its <c>label</c> or, in case of a software configuration item, its <c>name</c> field value.</br>
        /// </summary>
        /// <param name="labelOrName">The label of a software configuration, or name of the software configuration item.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput ConfigurationItem(string labelOrName)
        {
            AddToEventRequestFields("ci", labelOrName);
            return this;
        }

        /// <summary>
        /// <br>Used to specify the configuration item that is to be related to the request.</br>
        /// <br>The configuration item will be identified by its <c>ID</c>.</br>
        /// </summary>
        /// <param name="ID">The REST API identifier of the configuration item.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput ConfigurationItem(long ID)
        {
            AddToEventRequestFields("ci_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the configuration item that is to be related to the request.</br>
        /// <br>The configuration item will be identified by its <c>source</c> and <c>sourceID</c>.</br>
        /// </summary>
        /// <param name="source">The source of the configuration item.</param>
        /// <param name="sourceID">The sourceID of the configuration item.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput ConfigurationItem(string source, string sourceID)
        {
            AddToEventRequestFields("ci_source", source);
            AddToEventRequestFields("ci_sourceID", sourceID);
            return this;
        }

        /// <summary>
        /// <br>Used to specify the configuration item that is to be related to the request.</br>
        /// <br>The configuration will be identified by its <c>ID</c>, or by its <c>source</c> and <c>sourceID</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="configurationItem">The configuration item.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput ConfigurationItem(ConfigurationItem configurationItem) 
        {
            if (string.IsNullOrEmpty(configurationItem.ID))
            {
                AddToEventRequestFields("ci_id", configurationItem.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(configurationItem.Source) && !string.IsNullOrEmpty(configurationItem.SourceID))
            {
                AddToEventRequestFields("ci_source", configurationItem.Source);
                AddToEventRequestFields("ci_sourceID", configurationItem.SourceID);
            }
            else
            {
                throw new Sdk4meException("The configuration item ID, or source and sourceID, are null or empty.");

            }
            return this;
        }

        /// <summary>
        /// Used to specify an option in the completion reason field of the request when its status field is set to <c>completed</c>.
        /// </summary>
        /// <param name="reason">The completion reason.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput CompletionReason(RequestCompletionReason reason) 
        {
            AddToEventRequestFields("completion_reason", reason.GetEnumMemberValue());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the date and time that has been agreed on for the completion of the request.</br>
        /// <br>The desired completion overwrites the automatically calculated resolution target of any affected SLA that is related to the request when the desired completion is later than the affected SLA's resolution target.</br>
        /// <br>By default, the <c>requested_by</c> receives a notification based on the ‘Desired Completion Set for Request’ email template whenever the <c>desired_completion_at</c> is set, updated or removed.</br>
        /// </summary>
        /// <param name="desiredCompletionAt">The desire completion at.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput DesiredCompletionAt(DateTime desiredCompletionAt)
        {
            AddToEventRequestFields("desired_completion_at", desiredCompletionAt.ToString("o"));
            return this;
        }

        /// <summary>
        /// Used to specify the end date and time of a service outage.
        /// </summary>
        /// <param name="downtimeEndAt">The downtime end at.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput DownTimeEndAt(DateTime downtimeEndAt)
        {
            AddToEventRequestFields("downtime_end_at", downtimeEndAt.ToString("o"));
            return this;
        }

        /// <summary>
        /// Used to specify the start date and time of a service outage.
        /// </summary>
        /// <param name="downtimeStartAt">The downtime start at.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput DownTimeStartAt(DateTime downtimeStartAt)
        {
            AddToEventRequestFields("downtime_start_at", downtimeStartAt.ToString("o"));
            return this;
        }

        /// <summary>
        /// Used to specify an option in the impact field of the request.
        /// </summary>
        /// <param name="requestImpact">The request impact.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Impact(RequestImpact requestImpact)
        {
            AddToEventRequestFields("impact", requestImpact.GetEnumMemberValue());
            return this;
        }

        /// <summary>
        /// Used to provide the text that needs to be added as an internal note to the request.
        /// </summary>
        /// <param name="text">The internal note text.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput InternalNote(string text)
        {
            AddToEventRequestFields("internal_note", text);
            return this;
        }

        /// <summary>
        /// Used to specify the person to which the request is to be assigned.
        /// </summary>
        /// <param name="primaryEmailAddress">The person's primary email address.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Member(string primaryEmailAddress)
        {
            AddToEventRequestFields("member", primaryEmailAddress);
            return this;
        }

        /// <summary>
        /// Used to specify the person to which the request is to be assigned.
        /// </summary>
        /// <param name="ID">The person's REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Member(long ID)
        {
            AddToEventRequestFields("member_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the person to which the request is to be assigned.</br>
        /// <br>The person will be identified by its <c>ID</c>, or by its <c>primary email</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="person">The person.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput Member(Person person)
        {
            if (string.IsNullOrEmpty(person.ID))
            {
                AddToEventRequestFields("member_id", person.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(person.PrimaryEmail))
            {
                AddToEventRequestFields("member", person.PrimaryEmail);
            }
            else
            {
                throw new Sdk4meException("The person ID and primary email address are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to provide the text that needs to be added as an note to the request.
        /// </summary>
        /// <param name="text">The note text.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Note(string text)
        {
            AddToEventRequestFields("note", text);
            return this;
        }

        /// <summary>
        /// Used to specify the problem that is to be related to the request.
        /// </summary>
        /// <param name="ID">The REST API identifier of the problem.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Problem(long ID)
        {
            AddToEventRequestFields("problem_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the problem that is to be related to the request.</br>
        /// <br>The problem will be identified by its <c>ID</c>.</br>
        /// </summary>
        /// <param name="problem">The problem.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput Problem(Problem problem)
        {
            if (string.IsNullOrEmpty(problem.ID))
            {
                AddToEventRequestFields("problem_id", problem.GetIdentifier().ToString());
            }
            else
            {
                throw new Sdk4meException("The problem ID is null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to specify the person who is to be selected in the requested by field of the request.
        /// </summary>
        /// <param name="primaryEmailAddress">The person's primary email address.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput RequestedBy(string primaryEmailAddress)
        {
            AddToEventRequestFields("requested_by", primaryEmailAddress);
            return this;
        }

        /// <summary>
        /// Used to specify the person who is to be selected in the requested by field of the request.
        /// </summary>
        /// <param name="ID">The person's REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput RequestedBy(long ID)
        {
            AddToEventRequestFields("requested_by_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the person who is to be selected in the requested by field of the request.</br>
        /// <br>The person will be identified by its <c>ID</c>, or by its <c>primary email</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="person">The person</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput RequestedBy(Person person)
        {
            if (string.IsNullOrEmpty(person.ID))
            {
                AddToEventRequestFields("requested_by_id", person.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(person.PrimaryEmail))
            {
                AddToEventRequestFields("requested_by", person.PrimaryEmail);
            }
            else
            {
                throw new Sdk4meException("The person ID and primary email address are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to specify the person who is to be selected in the Requested for field of the request.
        /// </summary>
        /// <param name="primaryEmailAddress">The person's primary email address.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput RequestedFor(string primaryEmailAddress)
        {
            AddToEventRequestFields("requested_for", primaryEmailAddress);
            return this;
        }

        /// <summary>
        /// Used to specify the person who is to be selected in the Requested for field of the request.
        /// </summary>
        /// <param name="ID">The person's REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput RequestedFor(long ID)
        {
            AddToEventRequestFields("requested_for_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the person who is to be selected in the Requested for field of the request.</br>
        /// <br>The person will be identified by its <c>ID</c>, or by its <c>primary email</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="person">The person</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput RequestedFor(Person person)
        {
            if (string.IsNullOrEmpty(person.ID))
            {
                AddToEventRequestFields("requested_for_id", person.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(person.PrimaryEmail))
            {
                AddToEventRequestFields("requested_for", person.PrimaryEmail);
            }
            else
            {
                throw new Sdk4meException("The person ID and primary email address are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to specify the service instance that is to be related to the request.
        /// </summary>
        /// <param name="name">The service instance name.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput ServiceInstance(string name)
        {
            AddToEventRequestFields("service_instance", name);
            return this;
        }

        /// <summary>
        /// Used to specify the service instance that is to be related to the request.
        /// </summary>
        /// <param name="ID">The service instance REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput ServiceInstance(long ID)
        {
            AddToEventRequestFields("service_instance_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the service instance that is to be related to the request.</br>
        /// <br>The service instance will be identified by its <c>ID</c>, or by its <c>name</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="serviceInstance">The service instance.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput ServiceInstance(ServiceInstance serviceInstance)
        {
            if (string.IsNullOrEmpty(serviceInstance.ID))
            {
                AddToEventRequestFields("service_instance_id", serviceInstance.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(serviceInstance.Name))
            {
                AddToEventRequestFields("service_instance", serviceInstance.Name);
            }
            else
            {
                throw new Sdk4meException("The service instance ID and name are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// <br>Used to specify the name of the monitoring tool, see <see href="https://developer.4me.com/v1/general/source/">source</see>.</br>
        /// <br>After the request has been created, this value is visible in its audit trail.</br>
        /// </summary>
        /// <param name="source">The source identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Source(string source) 
        {
            AddToEventRequestFields("source", source);
            return this;
        }

        /// <summary>
        /// <br>Used to specify the unique ID of the event for which the request is to be registered, see <see href="https://developer.4me.com/v1/general/source/">source</see>.</br>
        /// <br>After the request has been created, this value is visible in its audit trail.</br>
        /// </summary>
        /// <param name="sourceID">The source identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput SourceID(string sourceID)
        {
            AddToEventRequestFields("source_id", sourceID);
            return this;
        }

        /// <summary>
        /// Used to specify an option in the status field of the request.
        /// </summary>
        /// <param name="status">The request status.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Status(RequestStatus status)
        {
            AddToEventRequestFields("status", status.GetEnumMemberValue());
            return this;
        }

        /// <summary>
        /// Used to specify the subject of the request.
        /// </summary>
        /// <param name="subject">The subject text.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Subject(string subject)
        {
            AddToEventRequestFields("subject", subject);
            return this;
        }

        /// <summary>
        /// Used to specify the organization to which the request has been submitted.
        /// </summary>
        /// <param name="supplier">The organization name.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Supplier(string supplier)
        {
            AddToEventRequestFields("supplier", supplier);
            return this;
        }

        /// <summary>
        /// Used to specify the organization to which the request has been submitted.
        /// </summary>
        /// <param name="ID">The organization's REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Supplier(long ID)
        {
            AddToEventRequestFields("supplier_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// Used to specify the organization to which the request has been submitted.
        /// <br>The organization will be identified by its <c>ID</c>, or by its <c>name</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="supplier">The supplier's organization.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput Supplier(Organization supplier)
        {
            if (string.IsNullOrEmpty(supplier.ID))
            {
                AddToEventRequestFields("supplier_id", supplier.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(supplier.Name))
            {
                AddToEventRequestFields("supplier", supplier.Name);
            }
            else
            {
                throw new Sdk4meException("The service instance ID and name are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// <br>Used to specify the support domain account ID in which the request is to be registered.</br>
        /// <br>This parameter needs to be specified when the current user's person record is registered in a directory account.</br>
        /// <br>The ID of a 4me account can be found in the 'Account Overview' section of the Settings console.</br>
        /// </summary>
        /// <param name="supportDomain">The support domain identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput SupportDomain(string supportDomain)
        {
            AddToEventRequestFields("support_domain", supportDomain);
            return this;
        }

        /// <summary>
        /// <br>Used to specify the support domain account in which the request is to be registered.</br>
        /// <br>This parameter needs to be specified when the current user's person record is registered in a directory account.</br>
        /// </summary>
        /// <param name="supportDomain">The support domain account.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput SupportDomain(Account supportDomain)
        {
            AddToEventRequestFields("support_domain", supportDomain.ID);
            return this;
        }

        /// <summary>
        /// Used to specify the team to which the request is to be assigned.
        /// </summary>
        /// <param name="name">The team name.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Team(string name)
        {
            AddToEventRequestFields("team", name);
            return this;
        }

        /// <summary>
        /// Used to specify the team to which the request is to be assigned.
        /// </summary>
        /// <param name="ID">The team's REST API identifier.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Team(long ID)
        {
            AddToEventRequestFields("team_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// Used to specify the team to which the request is to be assigned.
        /// <br>The team will be identified by its <c>ID</c>, or by its <c>name</c> when the <c>ID</c> is <c>null</c> or empty.</br>
        /// </summary>
        /// <param name="team">The team.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput Team(Team team)
        {
            if (string.IsNullOrEmpty(team.ID))
            {
                AddToEventRequestFields("team_id", team.GetIdentifier().ToString());
            }
            else if (!string.IsNullOrEmpty(team.Name))
            {
                AddToEventRequestFields("team", team.Name);
            }
            else
            {
                throw new Sdk4meException("The team ID and name are null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to specify the request template that is to be applied to the request.
        /// </summary>
        /// <param name="ID">The REST API identifier of the request template.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput RequestTemplate(long ID)
        {
            AddToEventRequestFields("template_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the request template that is to be related to the request.</br>
        /// <br>The request template will be identified by its <c>ID</c>.</br>
        /// <br>It is important to note that the field values specified in the API call overwrite the values specified in the request template.</br>
        /// </summary>
        /// <param name="requestTemplate">The request template.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput RequestTemplate(RequestTemplate requestTemplate)
        {
            if (string.IsNullOrEmpty(requestTemplate.ID))
            {
                AddToEventRequestFields("template_id", requestTemplate.GetIdentifier().ToString());
            }
            else
            {
                throw new Sdk4meException("The request template ID is null or empty.");
            }
            return this;
        }

        /// <summary>
        /// Used to specify the date and time at which the status of the request is to be updated from <c>waiting_for</c> to <c>assigned</c>.
        /// </summary>
        /// <param name="waitingUntil">The downtime end at.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput WaitingUntil(DateTime waitingUntil)
        {
            AddToEventRequestFields("waiting_until", waitingUntil.ToString("o"));
            return this;
        }

        /// <summary>
        /// Used to specify the workflow that is to be related to the request.
        /// </summary>
        /// <param name="ID">The REST API identifier of the workflow.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        public RequestEventCreateInput Workflow(long ID)
        {
            AddToEventRequestFields("workflow_id", ID.ToString());
            return this;
        }

        /// <summary>
        /// <br>Used to specify the workflow that is to be related to the request.</br>
        /// <br>The workflow will be identified by its <c>ID</c>.</br>
        /// </summary>
        /// <param name="workflow">The workflow template.</param>
        /// <returns>The current <see cref="RequestEventCreateInput"/> instance.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public RequestEventCreateInput Workflow(Workflow workflow)
        {
            if (string.IsNullOrEmpty(workflow.ID))
            {
                AddToEventRequestFields("workflow_id", workflow.GetIdentifier().ToString());
            }
            else
            {
                throw new Sdk4meException("The workflow ID is null or empty.");
            }
            return this;
        }

        private void AddToEventRequestFields(string name, string value) 
        {
            if (eventRequestFields.ContainsKey(name))
                eventRequestFields[name] = HttpUtility.UrlEncode(value);
            else
                eventRequestFields.Add(name, HttpUtility.UrlEncode(value));
        }
    }
}
